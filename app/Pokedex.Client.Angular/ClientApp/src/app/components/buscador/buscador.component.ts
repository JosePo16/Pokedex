import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import { PokemonService } from '../../services/pokemon.service';
import { Constants } from '../../shared/constants';

@Component({
  selector: 'app-buscador',
  templateUrl: './buscador.component.html',
  styles: []
})
export class BuscadorComponent implements OnInit {
  @Output()
  enviar: EventEmitter<any> = new EventEmitter<any>();

  keyword = 'nameenglish';
  data: any;

  constructor(private pokemonService: PokemonService) { }

  ngOnInit(): void {
    this.GetAll()
  }

  GetAll() {
    this.pokemonService.ListPokemonAll().subscribe((response) => {
      this.data = response.lstPokemon
      localStorage.setItem(Constants.KeyLocalStorage.KEY_LISTA_POKEMON, JSON.stringify(this.data));
    });
  }

    selectEvent(item: any) {
      this.enviar.emit(item);
    }
  
}
