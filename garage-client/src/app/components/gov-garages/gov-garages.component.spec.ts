import { ComponentFixture, TestBed } from '@angular/core/testing';

import { GovGaragesComponent } from './gov-garages.component';

describe('GovGaragesComponent', () => {
  let component: GovGaragesComponent;
  let fixture: ComponentFixture<GovGaragesComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [GovGaragesComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(GovGaragesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
