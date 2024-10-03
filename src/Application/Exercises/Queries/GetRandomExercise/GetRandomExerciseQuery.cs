﻿using Domain.Exercises;
using Domain.Lessons.ValueObjects;
using ErrorOr;
using MediatR;

namespace Application.Exercises.Queries.GetRandomExercise;

public record GetRandomExerciseQuery(LessonId LessonId) : IRequest<ErrorOr<Exercise>>;