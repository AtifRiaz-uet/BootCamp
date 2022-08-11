import { NONE_TYPE } from '@angular/compiler';
import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'AngularTask';
  login! : boolean;
  msg! :string;
  check!:number;
  constructor() {this.login=true;}


  clickEvent(){
    this.msg='Logout is Clicked';
    this.login =false;
    return this.msg;
  }

  btnclicked()
  {
    this.msg='Login is Clicked';
    this.login =true;
    return this.msg;
  }
}