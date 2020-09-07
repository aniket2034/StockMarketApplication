import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { AdminManageIPOComponent } from './admin-manage-ipo.component';

describe('AdminManageIPOComponent', () => {
  let component: AdminManageIPOComponent;
  let fixture: ComponentFixture<AdminManageIPOComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ AdminManageIPOComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(AdminManageIPOComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
