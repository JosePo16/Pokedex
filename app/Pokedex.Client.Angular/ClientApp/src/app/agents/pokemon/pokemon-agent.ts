import { Observable } from 'rxjs';
import { Injectable } from '@angular/core';
import { Constants } from '../../shared/constants';
import { StorageService } from '../../services/storage.service';
import { PathOperation } from './path-pokemon';
import { ListPokemonResponse } from './response/list-pokemon-all-response';
import { HttpClient } from '@angular/common/http';
import { ListPokemonByRange } from './request/list-pokemon-by-range-request';

@Injectable()
export class PokemonAgent {

  private PokedexUrl: string;

  constructor(
    storageService: StorageService,
    private http: HttpClient)
  {
    this.PokedexUrl = storageService.retrieve(Constants.SistemaUrl.POKEDEX_URL);
  }

  ListPokemonAll(): Observable<ListPokemonResponse> {
    let path = PathOperation.ListAll;
    return this.http.get(path) as Observable<ListPokemonResponse>;
  }

  ListPokemonByRange(request: ListPokemonByRange): Observable<ListPokemonResponse> {
    let path = PathOperation.ListByRange + '?ini=' + request.Ini + '&fin=' + request.Fin;
    return this.http.get(path) as Observable<ListPokemonResponse>;
  }
}
