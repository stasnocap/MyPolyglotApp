﻿using Application.Practice.Lessons.Common;
using Domain.Practice.Lessons.ValueObjects;
using MediatR;

namespace Application.Practice.Lessons.Queries.GetLessons;

public record GetLessonsQuery(string? SearchTerm) : IRequest<IReadOnlyList<LessonResult>>;