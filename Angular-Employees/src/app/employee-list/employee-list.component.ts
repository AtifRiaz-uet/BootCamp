import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import { InteractionService } from '../interaction.service';
import { Employe } from '../Model/Employe';


@Component({
  selector: 'app-employee-list',
  templateUrl: './employee-list.component.html',
  styleUrls: ['./employee-list.component.css']
})
export class EmployeeListComponent implements OnInit {

  constructor(private _interactionService:InteractionService) {}

  employees=InteractionService.getEmployeList();

   

  @Output() clickedEmp = new EventEmitter<Employe>();
  // @Output() listEmp = new EventEmitter<Employe[]>();
  

  ngOnInit(): void {
  }
  clicked (Emp: Employe)
  {
    this.clickedEmp.emit(Emp);
    // this.listEmp.emit(this.employees)
  }

}

