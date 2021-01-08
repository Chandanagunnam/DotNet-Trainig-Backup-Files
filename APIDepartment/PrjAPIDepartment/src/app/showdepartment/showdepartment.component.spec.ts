import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ShowdepartmentComponent } from './showdepartment.component';

describe('ShowdepartmentComponent', () => {
  let component: ShowdepartmentComponent;
  let fixture: ComponentFixture<ShowdepartmentComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ShowdepartmentComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ShowdepartmentComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
