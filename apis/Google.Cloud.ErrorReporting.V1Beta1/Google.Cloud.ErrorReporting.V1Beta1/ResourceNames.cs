// Copyright 2016, Google Inc. All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

using Google.Api.Gax;
using System;
using System.Linq;

namespace Google.Cloud.ErrorReporting.V1Beta1
{
    /// <summary>
    /// Resource name for the 'project' resource.
    /// </summary>
    public sealed partial class ProjectName : IResourceName, IEquatable<ProjectName>
    {
        private static readonly PathTemplate s_template = new PathTemplate("projects/{project}");

        /// <summary>
        /// Parses a project resource name in string form into a <see cref="ProjectName"/>.
        /// </summary>
        /// <param name="projectName">The project resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ProjectName"/> if successful.</returns>
        public static ProjectName Parse(string projectName)
        {
            GaxPreconditions.CheckNotNull(projectName, nameof(projectName));
            TemplatedResourceName resourceName = s_template.ParseName(projectName);
            return new ProjectName(resourceName[0]);
        }

        /// <summary>
        /// Tries to parse project resource name in string form into a <see cref="ProjectName"/>/
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="ArgumentNullException"/> if <paramref name="projectName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="projectName">The project resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="ProjectName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed succssfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string projectName, out ProjectName result)
        {
            GaxPreconditions.CheckNotNull(projectName, nameof(projectName));
            TemplatedResourceName resourceName;
            if (s_template.TryParseName(projectName, out resourceName))
            {
                result = new ProjectName(resourceName[0]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a project name from its component parts.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be <c>null</c>.</param>
        public ProjectName(string projectId)
        {
            ProjectId = GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
        }

        /// <summary>
        /// The project ID. Never <c>null</c>.
        /// </summary>
        public string ProjectId { get; }

        /// <inheritdoc />
        public ResourceNameKind Kind => ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(ProjectId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as ProjectName);

        /// <inheritdoc />
        public bool Equals(ProjectName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(ProjectName a, ProjectName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(ProjectName a, ProjectName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'group' resource.
    /// </summary>
    public sealed partial class GroupName : IResourceName, IEquatable<GroupName>
    {
        private static readonly PathTemplate s_template = new PathTemplate("projects/{project}/groups/{group}");

        /// <summary>
        /// Parses a group resource name in string form into a <see cref="GroupName"/>.
        /// </summary>
        /// <param name="groupName">The group resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="GroupName"/> if successful.</returns>
        public static GroupName Parse(string groupName)
        {
            GaxPreconditions.CheckNotNull(groupName, nameof(groupName));
            TemplatedResourceName resourceName = s_template.ParseName(groupName);
            return new GroupName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse group resource name in string form into a <see cref="GroupName"/>/
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="ArgumentNullException"/> if <paramref name="groupName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="groupName">The group resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="GroupName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed succssfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string groupName, out GroupName result)
        {
            GaxPreconditions.CheckNotNull(groupName, nameof(groupName));
            TemplatedResourceName resourceName;
            if (s_template.TryParseName(groupName, out resourceName))
            {
                result = new GroupName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a group name from its component parts.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be <c>null</c>.</param>
        /// <param name="groupId">The group ID. Must not be <c>null</c>.</param>
        public GroupName(string projectId, string groupId)
        {
            ProjectId = GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            GroupId = GaxPreconditions.CheckNotNull(groupId, nameof(groupId));
        }

        /// <summary>
        /// The project ID. Never <c>null</c>.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The group ID. Never <c>null</c>.
        /// </summary>
        public string GroupId { get; }

        /// <inheritdoc />
        public ResourceNameKind Kind => ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(ProjectId, GroupId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as GroupName);

        /// <inheritdoc />
        public bool Equals(GroupName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(GroupName a, GroupName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(GroupName a, GroupName b) => !(a == b);
    }


    public partial class DeleteEventsRequest
    {
        /// <summary>
        /// A <see cref="ProjectName"/>-typed view over the <see cref="ProjectName"/> resource name property.
        /// </summary>
        public ProjectName ProjectNameAsProjectName
        {
            get { return string.IsNullOrEmpty(ProjectName) ? null : Google.Cloud.ErrorReporting.V1Beta1.ProjectName.Parse(ProjectName); }
            set { ProjectName = value != null ? value.ToString() : ""; }
        }

    }

    public partial class GetGroupRequest
    {
        /// <summary>
        /// A <see cref="GroupName"/>-typed view over the <see cref="GroupName"/> resource name property.
        /// </summary>
        public GroupName GroupNameAsGroupName
        {
            get { return string.IsNullOrEmpty(GroupName) ? null : Google.Cloud.ErrorReporting.V1Beta1.GroupName.Parse(GroupName); }
            set { GroupName = value != null ? value.ToString() : ""; }
        }

    }

    public partial class ListEventsRequest
    {
        /// <summary>
        /// A <see cref="ProjectName"/>-typed view over the <see cref="ProjectName"/> resource name property.
        /// </summary>
        public ProjectName ProjectNameAsProjectName
        {
            get { return string.IsNullOrEmpty(ProjectName) ? null : Google.Cloud.ErrorReporting.V1Beta1.ProjectName.Parse(ProjectName); }
            set { ProjectName = value != null ? value.ToString() : ""; }
        }

    }

    public partial class ListGroupStatsRequest
    {
        /// <summary>
        /// A <see cref="ProjectName"/>-typed view over the <see cref="ProjectName"/> resource name property.
        /// </summary>
        public ProjectName ProjectNameAsProjectName
        {
            get { return string.IsNullOrEmpty(ProjectName) ? null : Google.Cloud.ErrorReporting.V1Beta1.ProjectName.Parse(ProjectName); }
            set { ProjectName = value != null ? value.ToString() : ""; }
        }

    }

    public partial class ReportErrorEventRequest
    {
        /// <summary>
        /// A <see cref="ProjectName"/>-typed view over the <see cref="ProjectName"/> resource name property.
        /// </summary>
        public ProjectName ProjectNameAsProjectName
        {
            get { return string.IsNullOrEmpty(ProjectName) ? null : Google.Cloud.ErrorReporting.V1Beta1.ProjectName.Parse(ProjectName); }
            set { ProjectName = value != null ? value.ToString() : ""; }
        }

    }

}