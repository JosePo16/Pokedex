import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { PokemonDto } from 'src/app/models/dto/pokemon-dto';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {

  conversion: any;
  lstPokemon: PokemonDto[];
  maxColumn: number = 3;

  constructor(private http: HttpClient) { }
  

  ngOnInit() {
    this.lstPokemon = [];
    this.http.get('api/pokemon/getall')
      .subscribe(data => {
        this.conversion = data;
        this.lstPokemon = this.conversion;
        
        console.log('prueba', this.lstPokemon);
      });
  }
}
