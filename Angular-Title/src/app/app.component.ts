import { Component, EventEmitter, Output } from '@angular/core';
import { Todo } from './Model/Todo';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {

  _title:string='';
  _description:string='';

  // title!:string;
  // description!:string;
  info_dict!:{};
  info_list:any[]=[];

  submit()
  {
    if (this._title !== '' && this._description !== '')
    {
      console.log("clicked");
    this.info_dict={'title':this._title,'desp':this._description};
    this.info_list.push(this.info_dict);
    this._title='';
    this._description='';
    }
    else{
      alert("Something is Missing!")
    }
    
  }
}
