import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import { TipoService } from '../../services/tipo.service';
import { TipoDto } from 'src/app/models/dto/tipo-dto';

@Component({
  selector: 'app-filtro',
  templateUrl: './filtro.component.html',
  styles: []
})
export class FiltroComponent implements OnInit{
  @Output()
  enviar: EventEmitter<string> = new EventEmitter<string>();

  keyword = 'english';
  data: any;
  constructor(private tipoService: TipoService) { }

  ngOnInit(): void {
    this.GetTipoAll();
    
  }

  GetTipoAll() {
    this.tipoService.ListTipoAll().subscribe((response) => this.data = response.lstTipo);
  }

  selectEvent(item: any) {
    this.enviar.emit(item.english);
  }
}
