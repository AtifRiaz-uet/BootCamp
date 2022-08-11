import { Component, Input, OnInit } from '@angular/core';
import { Todo } from '../Model/Todo';

@Component({
  selector: 'app-todo',
  templateUrl: './todo.list.component.html',
  styleUrls: ['./todo.list.component.css']
})
export class TodoListComponent implements OnInit {
  @Input()info!:Todo[];


  //  @Input()info!: {
  //   [key: string]: string;
  // };

  



  // getinfo(a:[string,string])
  // {
  //   this.infolist=a;
  // }

  ngOnInit(): void {
  }


}
