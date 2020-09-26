import { Injectable } from "@angular/core"
import { Router, CanActivate, ActivatedRouteSnapshot, RouterStateSnapshot, NavigationEnd } from "@angular/router"
import { UsuarioServico } from "../servicos/usuario/usuario.service";

@Injectable({
  providedIn: 'root'
})

export class GuardaRota implements CanActivate {

  constructor(private router : Router, private usuarioServico : UsuarioServico)
  { }

  canActivate(route: ActivatedRouteSnapshot, state: RouterStateSnapshot): boolean
  {
    //preenchendo o metodo estaLogado()
    this.usuarioServico.usuario;

    if (this.usuarioServico.estaLogado()) return true;

    else
    {
      this.router.navigate(['/login'], { queryParams: { returnUrl: state.url}});
      return false;
    }
    
  }

}
