import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import { Employe } from '../Model/Employe';

let Employeone = new Employe();
Employeone.employe_name='Daim';
Employeone.employe_id = 1;
Employeone.employe_age = 22;

let Employetwo = new Employe();
Employetwo.employe_name='hozaifa';
Employetwo.employe_id = 2;
Employetwo.employe_age = 23;

var Employethree = new Employe();
Employethree.employe_name='Atif';
Employethree.employe_id = 3;
Employethree.employe_age = 21;



@Component({
  selector: 'app-employee-list',
  templateUrl: './employee-list.component.html',
  styleUrls: ['./employee-list.component.css']
})
export class EmployeeListComponent implements OnInit {

  employees : Employe [] =[
    {
      employe_id :1,
      employe_name: 'Daim',
      employe_age: 24
    },
    {
      employe_id: 2,
      employe_name:'Hozefa',
      employe_age:29,
    },
    {
      employe_id: 3,
      employe_name:'Junaid',
      employe_age:28,
    },
    {
      employe_id: 4,
      employe_name:'Nadeem',
      employe_age:39,
    }

  ]

  @Output() clickedEmp = new EventEmitter<Employe>();

 
  constructor() { }

  ngOnInit(): void {
  }
  clicked (Emp: Employe)
  {
    this.clickedEmp.emit(Emp);
  }

}

