import { FlexboxGrid, List } from 'rsuite';
import { IData } from '../../../types/IData';
import { IActionButton, IListingColumn } from '../../../types/IListing';
import { nanoid } from 'nanoid';
import IDCheckBox from './IdCheckBox';
import ActionButtonCollection from '../input/ActionButtonCollection';

interface IProps {
    id: number;
    data: IData;
    checked: boolean;
    columns: IListingColumn[];
    rowButtons?: IActionButton[];
    ignoreCheckbox?: boolean;
    refresh?: () => void;
    handleCheckboxClick: (id: number) => void;
}

const ListingRow = ({ id, data, checked, columns, rowButtons, refresh, handleCheckboxClick, ignoreCheckbox }: IProps) => {
    if (!id) return null;
    let colsLeft = 24 - (ignoreCheckbox ? 0 : 1);
    return (
        <List.Item key={nanoid()} className='listing-row'>
            <FlexboxGrid>
                {!ignoreCheckbox && (
                    <FlexboxGrid.Item className='listing-item' key='id' colspan={1}>
                        <IDCheckBox id={id} checked={checked} handleCheckboxClick={handleCheckboxClick} />
                    </FlexboxGrid.Item>
                )}

                {columns.map((col) => {
                    colsLeft -= col.colspan;

                    if (col.component) {
                        return (
                            <FlexboxGrid.Item className='listing-item' key={col.dataKey} colspan={col.colspan}>
                                {col.component(col.retrieveAllData ? data : data[col.dataKey], refresh)}
                            </FlexboxGrid.Item>
                        );
                    }
                    return (
                        <FlexboxGrid.Item className='listing-item' key={col.dataKey} colspan={col.colspan}>
                            <>{data[col.dataKey] ?? ''}</>
                        </FlexboxGrid.Item>
                    );
                })}
                <ActionButtonCollection className={'listing-item'} data={data} colspan={colsLeft} buttons={rowButtons} refresh={refresh} />
            </FlexboxGrid>
        </List.Item>
    );
};

export default ListingRow;
