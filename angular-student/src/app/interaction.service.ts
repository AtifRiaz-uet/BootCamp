import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Employe } from './Model/Employe';
import { HttpClient } from '@angular/common/http'



// export class InteractionService {
  
//    employees : Employe [] =[ ]
//   getEmployeList(): Employe [] {
//     return this.employees;
//   }

//   private _callforBtn = new Subject<any>()
//   gm$ = this._callforBtn.asObservable()
  
  
//   sendreq(emp:Employe){
//     this._callforBtn.next(emp);
//   }


//   constructor() { }
// }
@Injectable()
export class InteractionService {

  private _url:string = "http://localhost/WebAPI/api/Values";

  constructor(private http:HttpClient) { }

  getEmployeList(): Observable<Employe[]>{
    return this.http.get<Employe[]>(this._url)
  }

  getEmployeDetail(): Observable<Employe>{
    return this.http.get<Employe>(this._url)
  }
}