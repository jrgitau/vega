import { FeaturesService } from './../services/features.service';
import { MakesService } from './../services/makes.service';
import { Component, OnInit, ViewContainerRef } from '@angular/core';
import { ToastsManager } from 'ng2-toastr/ng2-toastr';
import { NotFoundError } from '../common/not-found-error';

@Component({
  selector: 'app-vehicle-form',
  templateUrl: './vehicle-form.component.html',
  styleUrls: ['./vehicle-form.component.css']
})
export class VehicleFormComponent implements OnInit {

  makes: any[];
  models: any[];
  features: any[];

  constructor(private makesService: MakesService,
    public toastr: ToastsManager, vcr: ViewContainerRef,
    private featuresService: FeaturesService
  ) {
    this.toastr.setRootViewContainerRef(vcr);
  }


  ngOnInit() {
    this.makesService.getMakes()
      .subscribe(
        response => {
        this.makes = response.json();
        console.log(this.makes);
      }, error => {
        if (error instanceof NotFoundError) {
            this.toastr.error('Model not found');
          }
        this.toastr.error('An unexpected error occured', 'Error');
      });

      this.featuresService.getFeatures()
      .subscribe(
        response => {
        this.features = response.json();
        console.log(this.features);
      }, error => {
        if (error instanceof NotFoundError) {
            this.toastr.error('Features not found');
          }
        this.toastr.error('An unexpected error occured', 'Error');
      });



  }
  onChange(deviceValue) {
    console.log(deviceValue);
    this.makesService.getModelsFromMake(deviceValue)
      .subscribe(response => {
        this.models = response.json();
      }, (error: Response) => {
        if (error instanceof NotFoundError) {
          this.toastr.error('Model not found');
        }
        this.toastr.error('An unexpected error occured');
      });
  }
}
