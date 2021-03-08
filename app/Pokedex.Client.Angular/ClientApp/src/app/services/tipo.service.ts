import { Injectable } from '@angular/core';
import { TipoAgent } from '../agents/tipo/tipo-agent';
import { Observable } from 'rxjs';
import { ListTipoResponse } from '../agents/tipo/response/list-tipo-all-response';
import { map } from 'rxjs/operators';


@Injectable({
  providedIn: 'root'
})
export class TipoService {
  private tipoAgent: TipoAgent;

  constructor(tipoAgent: TipoAgent) {
    this.tipoAgent = tipoAgent;
  }

  ListTipoAll(): Observable<ListTipoResponse> {
    return this.tipoAgent.ListTipoAll()
      .pipe(map((listScheduleResponse) => listScheduleResponse));
  }
}
