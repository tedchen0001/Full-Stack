import { Injectable } from '@angular/core';
import { Http } from '@angular/http';
import 'rxjs/add/operator/map'
import { Observable } from 'rxjs/Observable';

@Injectable()
export class HRDataService {
    private actionUrl: string;

    constructor(private _http: Http) {
        this.actionUrl = 'http://localhost:5000/api/EmpInfo';

    }

    public GetAllEmpInfo = (): Observable<any> => {
        return this._http.get(this.actionUrl).map(res => res.json());
        

    }
}  
