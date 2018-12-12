import { NotFoundError } from './../common/not-found-error';
import { Injectable } from '@angular/core';
import { Http } from '@angular/http';
import 'rxjs/add/operator/catch';
import 'rxjs/add/observable/throw';
import { Observable } from 'rxjs/Observable';
import { AppError } from './../common/app-error';


@Injectable()
export class MakesService {

  private getMakesUrl = 'https://localhost:5001/api/makes';
  private getModelsUrl = 'https://localhost:5001/api/makes/carmodels';

  constructor(private http: Http) { }

  getMakes() {
    return this.http.get(this.getMakesUrl)
    .catch((error: Response) => {
      if (error.status === 404) {
        return Observable.throw(new NotFoundError(error));
      }
      return Observable.throw(new AppError(error));
    });
  }
  getModelsFromMake(id) {
    return this.http.get(this.getModelsUrl + '/' + id).catch((error: Response) => {
      if (error.status === 404) {
        return Observable.throw(new NotFoundError(error));
      }
      return Observable.throw(new AppError(error));
    });


  }
}
