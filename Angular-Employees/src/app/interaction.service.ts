import { Injectable } from '@angular/core';
import { Subject } from 'rxjs';
import { Employe } from './Model/Employe';

@Injectable({
  providedIn: 'root'
})

export class InteractionService {
  static employees : Employe [] =[
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
  static getEmployeList(): any {
    return this.employees;
  }

  private _callforBtn = new Subject<any>()
  gm$ = this._callforBtn.asObservable()
  
  
  sendreq(emp:Employe){
    this._callforBtn.next(emp);
  }


  constructor() { }
}
