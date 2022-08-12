import { Component, Input, OnInit } from '@angular/core';
import { InteractionService } from '../interaction.service';
import { Employe } from '../Model/Employe';

@Component({
  selector: 'app-buttons',
  templateUrl: './buttons.component.html',
  styleUrls: ['./buttons.component.css']
})
export class ButtonsComponent implements OnInit {

  @Input () getemplist! : Employe [];
  @Input() empDetails! : Employe;



  

  constructor(private _interactionService:InteractionService) {}
  employees=InteractionService.getEmployeList();
  len=this.employees.length;
  previous()
  {
    if (this.empDetails !== undefined)
    {
      if (this.employees.indexOf(this.empDetails) - 1 >=0)
      {
        this._interactionService.sendreq(this.employees[this.employees.indexOf(this.empDetails) - 1])
        this.empDetails = this.employees[this.employees.indexOf(this.empDetails) - 1];
      }
      else
      {
        alert('This is the first!')
      }
      
    }
    
  }
  next()
  {
    if (this.empDetails !== undefined)
    {
      if (this.employees.indexOf(this.empDetails) + 1 <=3)
      {
        this._interactionService.sendreq(this.employees[this.employees.indexOf(this.empDetails) + 1])
        this.empDetails = this.employees[this.employees.indexOf(this.empDetails) + 1];
      }
      else
      {
        alert('Length of Employe is Reached!')
      }
      
    }


  }

  ngOnInit(): void {
  }

}
