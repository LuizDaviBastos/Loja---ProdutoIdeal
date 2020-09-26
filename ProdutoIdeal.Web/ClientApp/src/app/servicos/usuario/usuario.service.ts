import { } from "@angular/common"
import { Injectable, Inject } from "@angular/core";
import { HttpClient, HttpHeaders, HttpParams } from "@angular/common/http";
import { Observable } from "rxjs";
import { Usuario } from "../../../../model/Usuario";

@Injectable({
  providedIn:'root'
})


export class UsuarioServico
{

  private _usuario: Usuario;

  set usuario(usuario: Usuario) {

    sessionStorage.setItem("login", JSON.stringify(usuario));
    this._usuario = usuario;
  }

  get usuario() {
    var usuario = JSON.parse(JSON.parse(sessionStorage.getItem("login")));
    this._usuario = usuario;
    return this._usuario;
  }

  public estaLogado(): boolean
  {
    return (this._usuario != null && this._usuario.email != "" && this._usuario.senha != "");
  }

  public limparSessao() {
    sessionStorage.clear();
    this._usuario = null;
  }

  public _baseUrl: string;
  
  constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl : string)
  {
    this._baseUrl = baseUrl;
  }


  verificarUsuario(usuario : Usuario ): Observable<Usuario> {

    var headers = new HttpHeaders({ 'content-type': 'application/json' })
    var body = {
      email: usuario.email,
      senha: usuario.senha
    }
    
    return this.http.post<Usuario>(this._baseUrl + "api/usuario/verificaUsuario", body ,{ headers });
  }



}
