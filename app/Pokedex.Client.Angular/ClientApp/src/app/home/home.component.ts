import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {

  conversion: any;
  rta: [];

  constructor(private http: HttpClient) { }
  

  ngOnInit() {
    this.http.get('api/pokemon/getall')
      .subscribe(data => {
        this.conversion = data;
        this.rta = this.conversion;

        console.log('prueba', this.rta);
      });
  }

}
