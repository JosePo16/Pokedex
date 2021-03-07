import { Injectable } from '@angular/core';
import { PokemonAgent } from '../agents/pokemon/pokemon-agent';
import { Observable } from 'rxjs';
import { ListPokemonResponse } from '../agents/pokemon/response/list-pokemon-all-response';
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
}
