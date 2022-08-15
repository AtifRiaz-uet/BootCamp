import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import { map } from 'rxjs';
import { InteractionService } from '../interaction.service';
import { Employe } from '../Model/Employe';


@Component({
  selector: 'app-employee-list',
  templateUrl: './employee-list.component.html',
  styleUrls: ['./employee-list.component.css']
})
export class EmployeeListComponent implements OnInit {

  employees! : Employe[];

  constructor(private interactionService:InteractionService) {}
  


   

  @Output() clickedEmp = new EventEmitter<Employe>();
  // @Output() listEmp = new EventEmitter<Employe[]>();
  

  ngOnInit(): void {
    this.interactionService.getEmployeList()
    .pipe(map((data:any)=>
      {
        this.employees = data
      })
    )
    .subscribe()}
      
  clicked (Emp: Employe)
  {
    this.clickedEmp.emit(Emp);
    // this.listEmp.emit(this.employees)
  }

}

