import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ManageGaragesComponent } from './manage-garages.component';

describe('ManageGaragesComponent', () => {
  let component: ManageGaragesComponent;
  let fixture: ComponentFixture<ManageGaragesComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [ManageGaragesComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ManageGaragesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
