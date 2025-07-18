namespace ProjectManagement.Presentation.Endpoints.GetOrganization;

public record GetOrganizationResponse
(
    string OrganizationName,
    int ContributorsCount,
    string? Secret,
    Guid Identifier
);
