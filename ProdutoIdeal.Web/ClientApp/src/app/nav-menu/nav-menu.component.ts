import { Component } from '@angular/core';
import { UsuarioServico } from '../servicos/usuario/usuario.service';

@Component({
  selector: 'app-nav-menu',
  templateUrl: './nav-menu.component.html',
  styleUrls: ['./nav-menu.component.css']
})
export class NavMenuComponent {
  isExpanded = false;

  constructor(private usuarioServico: UsuarioServico)
  {

  }

  collapse() {
    this.isExpanded = false;
  }

  toggle() {
    this.isExpanded = !this.isExpanded;
  }

  logout() {

    this.usuarioServico.limparSessao();
  }

  getLogin() : boolean
  {
    return this.usuarioServico.estaLogado();
  }

}
