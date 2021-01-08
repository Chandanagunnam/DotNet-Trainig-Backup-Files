import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ArrayStudentComponent } from './array-student.component';

describe('ArrayStudentComponent', () => {
  let component: ArrayStudentComponent;
  let fixture: ComponentFixture<ArrayStudentComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ArrayStudentComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ArrayStudentComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
