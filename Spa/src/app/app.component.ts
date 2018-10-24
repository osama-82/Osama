import { Component } from '@angular/core';
import { DataService } from './_services/data.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  constructor(public dataService: DataService) 
  {}

  userInfo: string[];
  title = 'Spa';

  ngOnInit() {
    this.dataService.getUserData().subscribe((data: string[]) => {
      this.userInfo = data;
      console.log(this.userInfo);
    }, error => {
      console.log(error);
    });
  }
}
