import { Component, OnInit } from '@angular/core';
import { PokemonService } from '../../services/pokemon-service';

@Component({
  selector: 'app-buscador',
  templateUrl: './buscador.component.html',
  styles: []
})
export class BuscadorComponent implements OnInit{

  keyword = 'nameenglish';
  data: any;

  constructor(private pokemonService: PokemonService) { }

  ngOnInit(): void {
    this.GetAll() 
  }


  GetAll() {
    this.pokemonService.ListPokemonAll().subscribe((response) => this.data = response.lstPokemon);
  }

  selectEvent(item: any) {
    console.log(item);
  }
}
