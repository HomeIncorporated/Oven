using MasterBuilder.Interfaces;
using MasterBuilder.Request;

namespace MasterBuilder.Templates.React.Src.Pages
{
    /// <summary>
    /// HomePage.tsx Template
    /// </summary>
    public class HomePageTsxTemplate : ITemplate
    {
        private readonly Project Project;

        /// <summary>
        /// Constructor
        /// </summary>
        public HomePageTsxTemplate(Project project)
        {
            Project = project;
        }

        /// <summary>
        /// Get file name
        /// </summary>
        public string GetFileName()
        {
            return "HomePage.tsx";
        }

        /// <summary>
        /// Get file content
        /// </summary>
        public string[] GetFilePath()
        {
            return new string[] { "src", "pages" };
        }

        /// <summary>
        /// Get file content
        /// </summary>
        public string GetFileContent()
        {
            return @"import { StyleRulesCallback, Typography, WithStyles, withStyles } from '@material-ui/core';
import * as React from 'react';
import { connect } from 'react-redux';
import { RouteComponentProps } from 'react-router';
import { Todo } from '../model/model';
import { RootState } from '../reducers';

export namespace HomePage {
  export interface Props extends RouteComponentProps<void> {
    todoList: Todo[];
  }
}

class HomePage extends React.Component<WithStyles & HomePage.Props> {

  render() {
    return (
      <div className={this.props.classes.root}>
        <Typography variant=""display1"" gutterBottom>
          You have {this.props.todoList.length} TODOs in your list!
        </Typography>
      </div>
    );
  }
}

const styles: StyleRulesCallback = theme => ({
  root: {
    textAlign: 'center',
    paddingTop: theme.spacing.unit * 20,
  },
});

function mapStateToProps(state: RootState) {
  return {
    todoList: state.todoList
  };
}

export default (withStyles(styles)<{}>(connect(mapStateToProps)(HomePage)));
";
        }
    }
}