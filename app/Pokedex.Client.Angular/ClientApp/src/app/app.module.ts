import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { RouterModule } from '@angular/router';
import { AutocompleteLibModule } from 'angular-ng-autocomplete';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { PrincipalComponent } from './components/principal/principal.component';
import { DetalleComponent } from './components/detalle/detalle.component';
import { BuscadorComponent } from './components/buscador/buscador.component';
import { FiltroComponent } from './components/filtro/filtro.component';

import { PokemonAgent } from './agents/pokemon/pokemon-agent';
import { NgForIfEmpty } from './shared/ngforifempty';


@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    PrincipalComponent,
    DetalleComponent,
    BuscadorComponent,
    FiltroComponent,
    NgForIfEmpty
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: PrincipalComponent, pathMatch: 'full' },
    ]),
    AutocompleteLibModule,
  ],
  providers: [
    PokemonAgent
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
