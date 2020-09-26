import { Component, Inject } from "@angular/core"
import { HttpClient } from "@angular/common/http";


@Component({
  selector: 'app-produto',
  template: '<html><div *ngFor="let item of prd"><p>Nome: {{ item.nome }} </p><p> Valor: {{item.valor}} </p> <br /></div></html>'
})

export class ProdutoComponent {

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string)
  {
    http.get<produtos[]>(baseUrl + "api/Produto").subscribe(result => { this.prd = result; }, error => { this.prd = error; });
    this.nome = baseUrl + "api/Produto";
  }

  public prd: produtos[];
  public nome: string;

  getNome(): string {
    this.nome = "Xbox";
    return this.nome;
  }

}
interface produtos
{
  id : number
  nome: string
  descricao: string;
  valor: number;
}
