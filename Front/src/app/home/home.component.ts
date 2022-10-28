import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {

  user: string | null = null;
  
  constructor() { }

  ngOnInit(): void {
    if(localStorage.getItem("mail"))
    {
          this.user = localStorage.getItem("mail");
    }
  }

}
