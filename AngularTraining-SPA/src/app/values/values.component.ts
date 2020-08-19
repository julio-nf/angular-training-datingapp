import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { error } from '@angular/compiler/src/util';

@Component({
  selector: 'app-values',
  templateUrl: './values.component.html',
  styleUrls: ['./values.component.css']
})
export class ValuesComponent implements OnInit {
  values: any;

  constructor(private http: HttpClient) { }

  ngOnInit() {
    this.GetValues();
  }

  GetValues() {
    this.http.get('http://localhost:5000/api/values/')
      .subscribe(vl => this.values = vl, error => console.log(error));
  }

}
