import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { DepositoComponent } from './deposito/deposito.component';
import { HomeComponent } from './home/home.component';
import { IniciarsesionComponent } from './iniciarsesion/iniciarsesion.component';
import { MistransaccionesComponent } from './mistransacciones/mistransacciones.component';
import { P2pComponent } from './p2p/p2p.component';
import { RegistrarseComponent } from './registrarse/registrarse.component';
import { TarjetasComponent } from './tarjetas/tarjetas.component';
import { TransferenciasComponent } from './transferencias/transferencias.component';

const routes: Routes = [

  {path: "iniciarsesion", component: IniciarsesionComponent},
  {path: "mistransacciones", component:MistransaccionesComponent},
  {path: "registrarse", component: RegistrarseComponent},
  {path: "deposito", component:DepositoComponent},
  {path: "p2p", component:P2pComponent},
  {path: "", component:HomeComponent},
  {path: "tarjetas", component: TarjetasComponent},
  {path: "transferencias", component: TransferenciasComponent},
  
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
