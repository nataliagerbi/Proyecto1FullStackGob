import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { IniciarsesionComponent } from './iniciarsesion/iniciarsesion.component';
import { HomeComponent } from './home/home.component';
import { MistransaccionesComponent } from './mistransacciones/mistransacciones.component';
import { RegistrarseComponent } from './registrarse/registrarse.component';
import { DepositoComponent } from './deposito/deposito.component';
import { P2pComponent } from './p2p/p2p.component';
import { TarjetasComponent } from './tarjetas/tarjetas.component';
import { TransferenciasComponent } from './transferencias/transferencias.component';

@NgModule({
  declarations: [
    AppComponent,
    IniciarsesionComponent,
    HomeComponent,
    MistransaccionesComponent,
    RegistrarseComponent,
    DepositoComponent,
    
    P2pComponent,
         TarjetasComponent,
         TransferenciasComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
