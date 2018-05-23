using MasterBuilder.Interfaces;
using MasterBuilder.Request;

namespace MasterBuilder.Templates.React.Src.Reducers
{
    /// <summary>
    /// index.ts Template
    /// </summary>
    public class IndexTsTemplate : ITemplate
    {
        private readonly Project Project;

        /// <summary>
        /// Constructor
        /// </summary>
        public IndexTsTemplate(Project project)
        {
            Project = project;
        }

        /// <summary>
        /// Get file name
        /// </summary>
        public string GetFileName()
        {
            return "index.ts";
        }

        /// <summary>
        /// Get file content
        /// </summary>
        public string[] GetFilePath()
        {
            return new string[] { "src", "reducers" };
        }

        /// <summary>
        /// Get file content
        /// </summary>
        public string GetFileContent()
        {
            // TODO: add reducers here
            return @"import { combineReducers } from 'redux';
import * as todoReducder from './todo';
import { Todo } from '../model/model';

export interface RootState {
  todoList: Array<Todo>;
}

export default combineReducers<RootState>({
  ...todoReducder
});";
        }
    }
}