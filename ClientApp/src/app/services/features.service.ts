import { Http } from '@angular/http';
import { Injectable } from '@angular/core';
import 'rxjs/add/operator/catch';
import 'rxjs/add/observable/throw';
import { Observable } from 'rxjs/Observable';
import { AppError } from './../common/app-error';
import { NotFoundError } from './../common/not-found-error';


@Injectable()
export class FeaturesService {

  private getFeaturesUrl = 'https://localhost:5001/api/features';

  constructor(private http: Http) { }

  getFeatures() {
    return this.http.get(this.getFeaturesUrl)
    .catch((error: Response) => {
      if (error.status === 404) {
        return Observable.throw(new NotFoundError(error));
      }
      return Observable.throw(new AppError(error));
    });
  }

}
