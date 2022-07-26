import { Component, OnInit, Output, EventEmitter } from '@angular/core';
import { DataService  } from '../../services/data.service';
import { AnswerService  } from '../../services/answer.service';

import { Data, Answer } from '../../Data';


@Component({
  selector: 'app-data',
  templateUrl: './data.component.html',
  styleUrls: ['./data.component.css']
})

export class DataComponent implements OnInit {

  @Output() btnClick = new EventEmitter();

  data: Data= {
    html: '',
    questions: []
  };
  answer: Answer= {
    QuestionId: "",
    answer: ""
  };
  name: string = " ";
  elementId: string=" ";
  status: boolean = true;
  trueFalse: boolean = true;
  active: boolean = false;
  status1: boolean = true;
  status2: boolean = true;
  country: string = " ";
  countryValue: string = " ";
  postCode: string = " ";
  postCodeValue: string = " ";
  constructor(private dataService: DataService, private answerService: AnswerService) { }
  
  ngOnInit(): void {
    // this.trueFalse=this.answerService.getAnswer(this.answer);
    this.answerService.getAnswer(this.answer);
    this.dataService.getData().subscribe((data) => (this.data = data)&&    
    (this.name=new DOMParser().parseFromString(this.data.html, 'text/html').body.childNodes[0].childNodes[0].textContent!)&&
    (this.country=new DOMParser().parseFromString(this.data.html, 'text/html').body.childNodes[0].childNodes[1].childNodes[0].textContent!)
    &&
    (this.countryValue=new DOMParser().parseFromString(this.data.html, 'text/html').body.childNodes[0].childNodes[1].childNodes[1].textContent!)&&
    (this.postCode=new DOMParser().parseFromString(this.data.html, 'text/html').body.childNodes[0].childNodes[2].childNodes[0].textContent!)&&
    (this.postCodeValue=new DOMParser().parseFromString(this.data.html, 'text/html').body.childNodes[0].childNodes[2].childNodes[1].textContent!));
    
    console.log(this.answer);
  }

overEvent(){if(this.active){this.status = !this.status;}}
overEvent1(){if(this.active){this.status1 = !this.status1;}}
overEvent2(){if(this.active){this.status2 = !this.status2;}}
activation(){(this.active = !this.active)}

toggle(event: Event): void {
  this.elementId= (event.target as Element).id;
  this.answer.QuestionId=this.elementId;
}
toggleAnswer(event: Event): void {
  let answerVale: string=(event.target as Element).textContent!;
  this.answer.answer=answerVale;

}
}

