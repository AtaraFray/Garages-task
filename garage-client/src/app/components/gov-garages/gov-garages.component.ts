import { Component , OnInit , Input ,Output ,EventEmitter} from '@angular/core';
import { Garage } from '../../classes/garage';

// Angular materials imports
import { MatProgressSpinnerModule } from '@angular/material/progress-spinner';
import { MatButtonModule } from '@angular/material/button';
import { FormControl, FormsModule, ReactiveFormsModule } from '@angular/forms';
import { MatSelectModule } from '@angular/material/select';
import { MatFormFieldModule } from '@angular/material/form-field';

@Component({
  selector: 'app-gov-garages',
  standalone: true,
  imports: [FormsModule, ReactiveFormsModule, MatSelectModule, MatFormFieldModule, MatProgressSpinnerModule, MatButtonModule],
  templateUrl: './gov-garages.component.html',
  styleUrl: './gov-garages.component.scss'
})
export class GovGaragesComponent  {
  @Input() garages: Array<Garage> = [];
  @Input() isLoading: boolean = true;
  @Output() addSelected = new EventEmitter<Array<Garage>>();

  selectedGarages = new FormControl<Garage[]>([]);

  addGarages() {
    this.addSelected.emit(this.selectedGarages.value  || []);
  }

}

