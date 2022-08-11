import { Component, EventEmitter, Output } from '@angular/core';
import { Todo } from './Model/Todo';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {

  title:string = '';
  description:string = '';



  // @Output() todolist = new EventEmitter<Todo>();
  title_name!:string;
  description_name!:string;
  title_names = [''];
  des_names = [''];
  infolist!:Todo[]
  // infodict!: {
  //   [key: string]: string;
  // };


  submit(){
    this.title_name=this.title
    this.description_name=this.description;
    // this.infodict={'name':this.title_name,'des':this.description_name};
    this.infolist.push((this.title_name,this.description_name))
    this.title='';
    this.description='';

  }


  // submit1()
  // {
  //   if (this.title != '' && this.description != '')
  // {
  //   var info:[string,string] = [this.title,this.description]
  //   this.todolist.emit(info);
  // }
  // }

  
}
