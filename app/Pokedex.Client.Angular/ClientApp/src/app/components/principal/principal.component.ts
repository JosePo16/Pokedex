import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { PokemonDto } from 'src/app/models/dto/pokemon-dto';
import { PokemonService } from '../../services/pokemon.service';
import { ListPokemonByRange } from '../../agents/pokemon/request/list-pokemon-by-range-request';
import { Constants } from '../../shared/constants';

@Component({
  selector: 'app-principal',
  templateUrl: './principal.component.html',
  styleUrls: ['./principal.component.css']
})
export class PrincipalComponent implements OnInit {
  range: number = 17;
  conversion: any;
  lstPokemon: PokemonDto[];
  maxColumn: number = 3;

  constructor(
    private pokemonService: PokemonService,
    private http: HttpClient) { }


  ngOnInit() {
    this.ClearLocalStorage();
    this.lstPokemon = [];
    this.GetByRange();
  }


  //ngOnInit() {
  //  this.lstPokemon = [];
  //  this.http.get('api/pokemon/getall')
  //    .subscribe(data => {
  //      this.conversion = data;
  //      this.lstPokemon = this.conversion;

  //      console.log('prueba', this.lstPokemon);
  //    });
  //}


  GetByRange() {
    
    let rango_anterior = this.GetLocalStorage();

    const request = new ListPokemonByRange();
    request.Ini = rango_anterior == 0 ? 1 : rango_anterior + 1;
    request.Fin = request.Ini + this.range;
    this.SaveLocalStorage(request.Fin);

    this.pokemonService.ListPokemonRange(request).subscribe((response) => {

      this.conversion = response;
      this.lstPokemon = this.conversion.lstPokemon;
    });
  }

  SaveLocalStorage(fin) {
    localStorage.setItem(Constants.KeyLocalStorage.KEY_RANGO_FIN, fin);
  }

  GetLocalStorage() {
    return Number(localStorage.getItem(Constants.KeyLocalStorage.KEY_RANGO_FIN));
  }

  ClearLocalStorage() {
    localStorage.removeItem(Constants.KeyLocalStorage.KEY_RANGO_FIN);
  };

  CargarPokemon() {
    this.GetByRange();
    console.log('cargando.. mas pokémon');
  }
}
