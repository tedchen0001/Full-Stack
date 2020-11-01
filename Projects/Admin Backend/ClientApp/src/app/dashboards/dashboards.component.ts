import { Component, OnInit } from '@angular/core';
import { HRDataService } from '../Services/HRDataService';
import { HREmployee } from '../HREmployee.Model';

@Component({
  selector: 'app-dashboards',
  templateUrl: './dashboards.component.html',
  styleUrls: ['./dashboards.component.css'],
  providers: [HRDataService]
})
export class DashboardsComponent implements OnInit {
  jobTitles: HREmployee[];
  selectedJobTitles: number;
  constructor(private hs: HRDataService) {
    this.hs.GetAllEmpInfo().subscribe(data => this.jobTitles = data,
      error => console.log(error),
      () => console.log('Get all complete'));
  }
  onSubmit() {
    console.log(this.selectedJobTitles);
    alert(this.selectedJobTitles);
  }
  ngOnInit() {
  }

}

