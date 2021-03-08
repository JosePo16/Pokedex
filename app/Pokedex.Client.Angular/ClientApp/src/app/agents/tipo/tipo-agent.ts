import { Observable } from 'rxjs';
import { Injectable } from '@angular/core';
import { Constants } from '../../shared/constants';
import { StorageService } from '../../services/storage.service';
import { PathOperation } from './path-tipo';
import { ListTipoResponse } from './response/list-tipo-all-response';
import { HttpClient } from '@angular/common/http';

@Injectable()
export class TipoAgent {

  private PokedexUrl: string;

  constructor(
    storageService: StorageService,
    private http: HttpClient) {
    this.PokedexUrl = storageService.retrieve(Constants.SistemaUrl.POKEDEX_URL);
  }

  ListTipoAll(): Observable<ListTipoResponse> {
    let path = PathOperation.ListAll;
    return this.http.get(path) as Observable<ListTipoResponse>;
  }
}
