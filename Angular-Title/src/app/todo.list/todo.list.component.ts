import { Component, Input, OnInit } from '@angular/core';
import { Todo } from '../Model/Todo';

@Component({
  selector: 'app-todo',
  templateUrl: './todo.list.component.html',
  styleUrls: ['./todo.list.component.css']
})
export class TodoListComponent implements OnInit {
  @Input () getinfolist!:any[]

  constructor() { }

  ngOnInit(): void {
  }

}