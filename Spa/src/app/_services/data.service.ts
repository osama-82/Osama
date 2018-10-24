import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';
import { HttpClient } from '@angular/common/http';

@Injectable()
export class DataService {
    constructor(private http: HttpClient) {
      }

      getUserData(): Observable<string[]> {
        return this.http.get('/api/Values').pipe(
            map((response: string[]) => {
                return response;
            })
        );
    }
}