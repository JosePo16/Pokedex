import { Observable } from 'rxjs';
import { Injectable } from '@angular/core';
import { Constants } from '../../shared/constants';
import { StorageService } from '../../services/storage-service';
import { PathOperation } from './path-pokemon';
import { ListPokemonResponse } from './response/list-pokemon-all-response';
import { HttpClient } from '@angular/common/http';

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
}
