import { Injectable } from '@angular/core';
import { PokemonAgent } from '../agents/pokemon/pokemon-agent';
import { Observable } from 'rxjs';
import { ListPokemonResponse } from '../agents/pokemon/response/list-pokemon-all-response';
import { ListPokemonByRange } from '../agents/pokemon/request/list-pokemon-by-range-request';
import { map } from 'rxjs/operators';


@Injectable({
  providedIn: 'root'
})
export class PokemonService {
  private pokemonAgent: PokemonAgent;

  constructor(pokemonAgent: PokemonAgent) {
    this.pokemonAgent = pokemonAgent;
  }

  ListPokemonAll(): Observable<ListPokemonResponse> {
    return this.pokemonAgent.ListPokemonAll()
      .pipe(map((listScheduleResponse) => listScheduleResponse));
  }

  ListPokemonRange(request: ListPokemonByRange): Observable<ListPokemonResponse> {
    return this.pokemonAgent.ListPokemonByRange(request)
      .pipe(map((listScheduleResponse) => listScheduleResponse));
  }
}
