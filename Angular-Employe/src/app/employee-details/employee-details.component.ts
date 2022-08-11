import { Component, OnInit,Input } from '@angular/core';
import { Employe } from '../Model/Employe';

@Component({
  selector: 'app-employee-details',
  templateUrl: './employee-details.component.html',
  styleUrls: ['./employee-details.component.css']
})
export class EmployeeDetailsComponent implements OnInit {
  @Input() empDetails? : Employe;
  constructor() { }

  ngOnInit(): void {
  }

}
