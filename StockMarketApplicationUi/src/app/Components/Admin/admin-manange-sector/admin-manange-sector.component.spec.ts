import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { AdminManangeSectorComponent } from './admin-manange-sector.component';

describe('AdminManangeSectorComponent', () => {
  let component: AdminManangeSectorComponent;
  let fixture: ComponentFixture<AdminManangeSectorComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ AdminManangeSectorComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(AdminManangeSectorComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
