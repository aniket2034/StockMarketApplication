import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { AdminUploadFileComponent } from './admin-upload-file.component';

describe('AdminUploadFileComponent', () => {
  let component: AdminUploadFileComponent;
  let fixture: ComponentFixture<AdminUploadFileComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ AdminUploadFileComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(AdminUploadFileComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
