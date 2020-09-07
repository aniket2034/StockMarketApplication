import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { AdminManageExchangeComponent } from './admin-manage-exchange.component';

describe('AdminManageExchangeComponent', () => {
  let component: AdminManageExchangeComponent;
  let fixture: ComponentFixture<AdminManageExchangeComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ AdminManageExchangeComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(AdminManageExchangeComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
