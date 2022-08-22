import { Injectable } from '@angular/core';
import { Observable, Subject } from 'rxjs';
import { Employe } from './Model/Employe';
import { HttpClient } from '@angular/common/http'
import { catchError, map, tap } from 'rxjs/operators';



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
  newEmploye=new Employe;

  private _url:string = "http://localhost/empAPI/api/Values";
  // private proxyurl:string = "https://cors-anywhere.herokuapp.com/";
  

  constructor(private http:HttpClient) { }

  getEmployeList(): Observable<Employe[]>{
    
    return this.http.get<Employe[]>(this._url)
    
  }

  getEmployeDetail(ID:number): Observable<Employe>{
    let _empurl = `http://localhost/empAPI/api/Values/${ID}`;
    return this.http.get<Employe>(_empurl)
  }
  getEmployeDelete(ID:number){
    let _delempurl = `http://localhost/empAPI/api/Values/${ID}`;
    return this.http.delete(_delempurl)

  }
  __empurl = `http://localhost/empAPI/api/Values/`;
  addNewEmploye(Name:string,ID:number,desg:string): Observable<Employe>{
      
    this.newEmploye = {
      Id:ID,
      Name:Name,
      Designation:desg
      }
    return this.http.post<Employe>(this.__empurl,this.newEmploye)
    

    
  }

  private _callforBtn = new Subject<any>()
  gm$ = this._callforBtn.asObservable()
  
  
  sendreq(emp:Employe){
    this._callforBtn.next(emp);
  }
}