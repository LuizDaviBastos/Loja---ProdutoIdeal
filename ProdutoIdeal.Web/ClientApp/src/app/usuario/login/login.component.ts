import { Component, OnInit } from "@angular/core"
import { Usuario } from "../../../../model/Usuario";
import { Router, UrlSegment, ActivatedRoute } from "@angular/router";
import { UsuarioServico } from "../../servicos/usuario/usuario.service";






@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ["./login.component.css"]
})

export class LoginComponent implements OnInit {

  public usuarioAprovado = false;
  public usuario: Usuario;
  public _returnUrl: ActivatedRoute;
  public mensagemError: string;

  public ativaSpinner: boolean;

  

  constructor(private router: Router, private returnUrl: ActivatedRoute, private usuarioServico: UsuarioServico) { }

  ngOnInit(): void
  {
    this._returnUrl = this.returnUrl;
    this.usuario = new Usuario();
    this.ativaSpinner = false;
  }


  entrar() {

    this.ativaSpinner = true;

    this.usuarioServico.verificarUsuario(this.usuario).subscribe(
      sucess => {
        this.usuarioServico.usuario = sucess;
        this.router.navigateByUrl(this._returnUrl.snapshot.queryParams["returnUrl"]);
      },
      error => {
        this.mensagemError = error.error.msg;
        this.ativaSpinner = false;
      });
  }
}
