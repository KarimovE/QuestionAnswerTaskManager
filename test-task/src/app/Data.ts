export interface Data {
  html: string;
  questions: Question[];
};

export interface Question {
  Id: number;
  text: string;
}

export interface Answer {
  QuestionId: string;
  answer: string;
}

  

