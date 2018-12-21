import { VehicleService } from '../services/vehicle.service';
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
  vehicle: any = {};
  models: any[];
  features: any[];

  constructor(private vehicleService: VehicleService,
    public toastr: ToastsManager, vcr: ViewContainerRef,
  ) {
    this.toastr.setRootViewContainerRef(vcr);
  }


  ngOnInit() {
    this.vehicleService.getMakes()
      .subscribe(
        response => {
        this.makes = response.json();
      }, error => {
        if (error instanceof NotFoundError) {
            this.toastr.error('Models not found');
          }
        this.toastr.error('An unexpected error occured', 'Error');
      });

      this.vehicleService.getFeatures()
      .subscribe(
        response => {
        this.features = response;
      }, error => {
        if (error instanceof NotFoundError) {
            this.toastr.error('Feaures not found');
          }
        this.toastr.error('An unexpected error occured', 'Error');
      });



  }


  OnMakeChange() {
    console.log('Vehicle: ', this.vehicle);
    const selectedMake = this.makes.find(m => m.id == this.vehicle.make);
    this.models = selectedMake ? selectedMake.carModels : [];
    console.log('Car Models ',this.models);
  }
}
