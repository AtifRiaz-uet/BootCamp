import { Component, Input, OnInit } from '@angular/core';
import { InteractionService } from '../interaction.service';
import { Employe } from '../Model/Employe';
import { map } from 'rxjs';

@Component({
  selector: 'app-buttons',
  templateUrl: './buttons.component.html',
  styleUrls: ['./buttons.component.css']
})
export class ButtonsComponent implements OnInit {

  employees!: Employe[];
  @Input() empDetails! : Employe;
  emptyemp!:Employe;
  trigger:Boolean=false;
  firstId?:number;
  lastId?:number;
  // flag:number=1;

  constructor(private interactionService:InteractionService) {}

  ngOnInit(): void {
    this.interactionService.getEmployeList()
    .pipe(map((data:Employe[])=>
      {
        this.employees=data;
        this.firstId = data[0].Id-1;
        this.lastId = data[data.length-1].Id+1;
      })
    )
    .subscribe()
  }
  
  // ngOnInit(): void {}
  
  empId:number=0;


  

  
  previous(emp:Employe)
  {
    if ( (emp.Id) - 1 !== this.firstId)
    {
      this.interactionService.sendreq(this.employees[this.employees.indexOf(emp) - 1])
    this.empDetails = this.employees[this.employees.indexOf(emp) - 1];

    }
    else{
      alert('This is the first!')
    }
    
    
    // if(emp.Id==0)
    // {
    
    //   this.empId-=1
    //   this.preemp(this.empId)
    // }
    // else
    // {
    //   this.empId=emp.Id
    //   this.preemp(this.empId);
    // }
  }

  preemp(empid:number){
    if ( (empid) - 1 !== this.firstId)
      {

        this.interactionService.sendreq(this.employees[this.employees.indexOf(this.empDetails) - 1])
        this.empDetails = this.employees[this.employees.indexOf(this.empDetails) - 1];
        this.interactionService.getEmployeDetail(( empid) - 1).subscribe(
          emp =>{ if (emp.Id!==0)
            {
              this.interactionService.sendreq(emp)
              this.empDetails=emp
            }
            else{
              this.empDetails=emp
              this.previous(this.empDetails)
            }
            
          });
        // this.index=( emp.Id) - 1;
        // this.interactionService.sendreq(this.empDetails);
        
        
      }
      else
      {
        alert('This is the first!')
      } 
  }


  next(emp:Employe)
  
  {
    if (( emp.Id) + 1 !==this.lastId)
    {
      this.interactionService.sendreq(this.employees[this.employees.indexOf(emp) + 1])
    this.empDetails = this.employees[this.employees.indexOf(emp) + 1];
    }
    else{
      alert('Length of Employe is Reached!')
    }
    
    // if(emp.Id==0)
    // {
    
    //   this.empId+=1
    //   this.nextemp(this.empId)
    // }
    // else
    // {
    //   this.empId=emp.Id
    //   this.nextemp(this.empId);
    // }
  }
  nextemp(empid:number)
  {
    if (( empid) + 1 !==this.lastId)
      {
        // this._interactionService.sendreq(this.employees[this.employees.indexOf(this.empDetails) + 1])
        // this.empDetails = this.employees[this.employees.indexOf(this.empDetails) + 1];
        this.interactionService.getEmployeDetail(( empid) + 1).subscribe(
          emp =>{ if (emp.Id!==0)
            {
              this.interactionService.sendreq(emp)
              this.empDetails=emp
            }
            else{
              // alert("Employe at this ID is deleted!")
              this.empDetails=emp
              this.next(this.empDetails)
            }
            
          });
        // this.index=( emp.Id) + 1;
        // this.interactionService.sendreq(this.empDetails);

        }
      else
      {
        alert('Length of Employe is Reached!')
      } 
  }
  add(emp:Employe)
  {
    this.interactionService.sendreq(this.emptyemp)
    this.trigger=true;

  }
  del(emp:Employe)
  {
    alert('Currrent Employe will be Deleted Permanently Are You Sure?')
    this.interactionService.getEmployeDelete(emp.Id).subscribe()

  }

  

}
