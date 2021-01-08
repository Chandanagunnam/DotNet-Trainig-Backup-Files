import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AssignmentreactiveComponent } from './assignmentreactive.component';

describe('AssignmentreactiveComponent', () => {
  let component: AssignmentreactiveComponent;
  let fixture: ComponentFixture<AssignmentreactiveComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AssignmentreactiveComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(AssignmentreactiveComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
